using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using HP.FOT.WxNotam.Webreferences;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace ProductsApp.Controllers
{
    public class TextWeathersController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };
        TextWeatherType[] textWeather;

        public TextWeatherType[] GetTextWeathers()
        {
            textWeather = GetTextWeathersFromDataFile();
            return textWeather;
        }

        private TextWeatherType[] GetTextWeathersFromDataFile()
        {
            RetrieveTextWeatherRS obj = new RetrieveTextWeatherRS();
            XmlSerializer sz = new XmlSerializer(typeof(RetrieveTextWeatherRS), "http://www.eds.com/AirlineSOASchema/TextWeather/RetrieveTextWeatherRS");
            var streamReader = new StreamReader(@"C:\tong\Software\Tong\Mobility\Android\WebApiSample\Getting Started with ASP.NET Web API (Tutorial Sample)\C#\ProductsApp\App_Data\RetrieveTextWeatherRSAll.txt");
            obj = (RetrieveTextWeatherRS)sz.Deserialize(streamReader);

            return ((RetrieveTextWeatherResponseType)obj.Items[1]).TextWeather.Take(20).ToArray();
        }

        public static T Deserialize<T>(string xmlObj) where T : class,new()
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextReader reader = new StreamReader(xmlObj))
            {
                return serializer.Deserialize(reader) as T;
            }

        }


        public IHttpActionResult GetTextWeather(string id)
        {
            if (textWeather == null)
            {
                textWeather = GetTextWeathersFromDataFile();
            }
            var product = textWeather.FirstOrDefault((p) => p.LocationCode == id.ToUpper());
            //if (product == null)
            //{
            //    return NotFound();
            //}
            return Ok(product);
        }
    }
}
