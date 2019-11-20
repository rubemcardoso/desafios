using DesafioMeiFacil.Domain.Entities;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioMeiFacil.CrossCutting.Util
{
    public static class ProdutoScrapService
    {
        public static async Task GetHtmlAsync(string nome, string regiao, List<Produto> produtosLista)
        {
            var url = "";

            if (!string.IsNullOrEmpty(regiao))
                url = $"https://{regiao}.olx.com.br/";
            else
                url = $"https://www.olx.com.br/brasil";

            if (!string.IsNullOrEmpty(nome))
                url += $"?q={nome}";

            
            var httpClient = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var ProductsHtml = htmlDocument.DocumentNode.Descendants("ul")
                                                        .Where(node => node.GetAttributeValue("id", "")
                                                        .Equals("main-ad-list")).ToList();

            var ProductListItems = ProductsHtml[0].Descendants("li")
                                                  .Where(node => node.GetAttributeValue("class", "")
                                                  .Equals("item") && node.GetAttributeValue("data-list_id", "") != null).ToList();

            foreach (var productListItem in ProductListItems)
            {
                var produto = new Produto();
                //id
                produto.ProdutoKey = Convert.ToInt64(productListItem.GetAttributeValue("data-list_id", ""));

                //Name
                produto.Titulo = productListItem.Descendants("h2")
                                                .Where(node => node.GetAttributeValue("class", "")
                                                .Equals("OLXad-list-title"))
                                                .FirstOrDefault()?.InnerHtml.Trim('\r', '\n', '\t');

                //Price
                var preco = Regex.Match(productListItem.Descendants("p")
                                       .Where(node => node.GetAttributeValue("class", "")
                                       .Equals("OLXad-list-price"))
                                       .FirstOrDefault()?
                                       .InnerHtml.Trim('\r', '\n', '\t') ?? ""
                                       , @"\d+.\d+");

                produto.Preco = (!preco.Success) ? (decimal?)null : Convert.ToDecimal(preco.Value);

                //Category
                produto.Categoria = productListItem.Descendants("p")
                                                   .Where(node => node.GetAttributeValue("class", "")
                                                   .Equals("text detail-category"))
                                                   .FirstOrDefault()?
                                                   .FirstChild.InnerHtml.Trim('\r', '\n', '\t');


                //Region
                produto.Regiao = Regex.Replace(productListItem.Descendants("p")
                                       .Where(node => node.GetAttributeValue("class", "")
                                       .Equals("text detail-region"))
                                       .FirstOrDefault()?.InnerHtml
                                       .Trim('\r', '\n', '\t'), @"\s+", string.Empty);

                //Url
                produto.Url = productListItem.Descendants("a").FirstOrDefault()
                                             .GetAttributeValue("href", "").Trim('\r', '\n', '\t');

                produtosLista.Add(produto);
            }
        }
    }
}
