using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Specify a Google Cloud Storage uri for the image
// or a publicly accessible HTTP or HTTPS uri.
var image = Image.FromUri(uri);
var client = ImageAnnotatorClient.Create();
var response = client.DetectDocumentText(image);
foreach (var page in response.Pages)
{
    foreach (var block in page.Blocks)
    {
        foreach (var paragraph in block.Paragraphs)
        {
            Console.WriteLine(string.Join("\n", paragraph.Words));
        }
    }
}