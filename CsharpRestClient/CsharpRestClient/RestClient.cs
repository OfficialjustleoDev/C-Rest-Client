using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsharpRestClient
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT, 
        DELETE
    }
     class RestClient
    {
        public string endPoint {  get; set; }

        public httpVerb httpMethod{ get; set; }

        public RestClient()
        {
            endPoint = String.Empty;

            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseVaule =string.Empty;

            HttpWebRequest request =(HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response =(HttpWebResponse) request.GetResponse())
            { 
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error Code: "+ response.StatusCode.ToString());
                }//Process he response stram...(Could Json,xml or html)

                using(Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {

                        strResponseVaule = reader.ReadToEnd();
                        
                        
                        }// End of StreamReader
                    }




                }// end of Resposnse stream
            
            
            
            
            
            }


            return strResponseVaule;
        }
    } 
}
