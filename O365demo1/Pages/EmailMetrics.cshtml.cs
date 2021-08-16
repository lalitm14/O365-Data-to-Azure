using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using O365demo1.Models;

namespace O365demo1.Pages
{
    public class EmailMetricsModel : PageModel
    {
        private const string emailBlobName = "m365mails";

        public List<EmailMetric> EmailMetrics;

        private readonly BlobServiceClient blobServiceClient;
        public EmailMetricsModel(BlobServiceClient blobServiceClient)
        {
            this.blobServiceClient = blobServiceClient;
        }
        public void OnGet()
        {
            EmailMetrics = ProcessBlobFiles();
        }

        // process 1 blob file - has multiple emails
        private void ProcessBlobEmails(List<EmailMetric> masterMetric, BlobClient emailBlob)
        {
            // using is to ensure memory is cleaned to prevent leakage
            using (var stream = new MemoryStream())
            {
                // bring the blob content to the host memory
                var response = emailBlob.DownloadTo(stream);
                var pos = stream.Seek(0, SeekOrigin.Begin);
                //stream dreader is class that formats the raw memory into text type
                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var jsonObj = JObject.Parse(line);

                        // extract sender
                        var sender = jsonObj.SelectToken("Sender.EmailAddress.Address")?.ToString();
                        // No sender - skip this one
                        if (string.IsNullOrEmpty(sender)) continue;

                        // extract and count up recipients
                        var totalRecipients = 0;
                        totalRecipients += jsonObj.SelectToken("ToRecipients")?.Children().Count() ?? 0;
                        totalRecipients += jsonObj.SelectToken("CcRecipients")?.Children().Count() ?? 0;
                        totalRecipients += jsonObj.SelectToken("BccRecipients")?.Children().Count() ?? 0;

                        //have sender and receipant number for single email, add to emai master metric
                        //sender exist in master
                        if (masterMetric.Any(eachMetric => eachMetric.Sender == sender))
                        {
                            // get existing and total receipant 
                            var existingMetric = masterMetric.First(eachMetric => eachMetric.Sender == sender);
                            existingMetric.RecipientsToEmail += totalRecipients;
                        }
                        //sender does not exist in master
                        else
                        {
                            masterMetric.Add(new EmailMetric
                            {
                                Sender = sender,
                                RecipientsToEmail = totalRecipients,
                            });
                        }

                    }
                }
            }
         }
            
            // Process multiple blob files - calls above function
        private List<EmailMetric> ProcessBlobFiles()
        {
            var masterMetric = new List<EmailMetric>();

            //find each blob in Azure storage
            var containerClient = blobServiceClient.GetBlobContainerClient(emailBlobName);
            foreach (var blob in containerClient.GetBlobs())
            {
                //call to process each blob
                var blobClient = containerClient.GetBlobClient(blob.Name);
                ProcessBlobEmails(masterMetric, blobClient);
            
            }
            return (masterMetric);
        }
    }
}
