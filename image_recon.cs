using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Specify a Google Cloud Storage uri for the image
// or a publicly accessible HTTP or HTTPS uri.
var image = Image.FromUri('https://github.com/AntoineDoyon/AI_Test/10390-Flexcom-4729-2019-03-27.pdf');
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
