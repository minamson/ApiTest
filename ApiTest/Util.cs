using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace ApiTest
{
    internal class Util
    {
        /// <summary>
        /// 화면중앙으로
        /// </summary>
        /// <param name="form">Form</param>
        public static void CenterScreen(Form form)
        {
            form.Location = new System.Drawing.Point(
            (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2),
            (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }


        public static void OpenChidView(Form parentForm, Form childForm)
        {
            childForm.Parent = parentForm;
            childForm.Show();
        }

        public static string ThousandFormat(string val)
        {
            if (val == null || val == string.Empty) return string.Empty;

            string ret = string.Empty;

            if (val != null & val != string.Empty)
                string.Format("{0:#,###}", long.Parse(val));
            else
                ret = val;

            return ret;
        }

        public static string Left(string target, int length)
        {
            if (target == null || target == string.Empty) return string.Empty;
            if (length <= target.Length)
            {
                return target.Substring(0, length);
            }
            return target;
        }

        public static string Mid(string target, int start)
        {
            if (target == null || target == string.Empty) return string.Empty;

            if (start <= target.Length)
            {
                return target.Substring(start - 1);
            }
            return target;
        }

        public static string Mid(string target, int start, int length)
        {
            if (target == null || target == string.Empty) return string.Empty;
            if (start <= target.Length)
            {
                if (start + length - 1 <= target.Length)
                {
                    return target.Substring(start - 1, length);
                }
                return target.Substring(start - 1);
            }
            return target;
        }

        public static string Right(string target, int length)
        {
            if (target == null || target == string.Empty) return string.Empty;
            if (length <= target.Length)
            {
                return target.Substring(target.Length - length);
            }
            return target;
        }



        /// <summary>
        /// Restful Post
        /// </summary>
        /// <param name="fullUrl">string full url</param>
        /// <returns>RestResponse</returns>
        public static RestResponse RestfulApi(string fullUrl, string jsonEntity, Method method)
        {
            var options = new RestClientOptions();
            //options.Timeout = TimeSpan.FromSeconds(1200);

            //var client = new RestClient(options);
            var client = new RestClient();
            var request = new RestRequest(fullUrl, method);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(jsonEntity);


            return client.Execute(request);

        }

        public static RestResponse RestfulGet(string fullUrl, string jsonEntity)
        {
            return RestfulApi(fullUrl, jsonEntity, Method.Get);
        }


        public static RestResponse RestfulPost(string fullUrl, string jsonEntity)
        {
            return RestfulApi(fullUrl, jsonEntity, Method.Post);
        }

        public static RestResponse RestfulPut(string fullUrl, string jsonEntity)
        {
            return RestfulApi(fullUrl, jsonEntity, Method.Put);
        }

        public static RestResponse RestfulDelete(string fullUrl, string jsonEntity)
        {
            return RestfulApi(fullUrl, jsonEntity, Method.Delete);
        }


        /// <summary>
        /// Restful Get
        /// </summary>
        /// <param name="fullUrl">string full url</param>
        /// <returns>RestResponse</returns>
        public static RestResponse RestfulGet(string fullUrl)
        {
            //var options = new RestClientOptions(this.baseUrl + this.downLoadParamUri);
            var options = new RestClientOptions(fullUrl);

            options.Timeout = TimeSpan.FromSeconds(1200);

            var client = new RestClient(options);
            var request = new RestRequest();

            return client.ExecuteGet(request);
        }


        //사용법
        //private void PrintedUpdate(List<Asts> printedAstsList)
        //{
        //    log.Debug(" ======== PrintedUpdate call begin =======");

        //    EntityUpload entityUpload = new EntityUpload();

        //    try
        //    {

        //        entityUpload.objects.astsList = printedAstsList;
        //        entityUpload.objectCount = astsList.Count;
        //        entityUpload.empty = false;
        //        entityUpload.status = "success";
        //        entityUpload.messageParams = "none";
        //        entityUpload.serviceMessage = "print label";
        //        entityUpload.messageKey = "";

        //        var uploadJson = JsonConvert.SerializeObject(entityUpload);
        //        log.Debug("printedAstsList uploadJson = " + uploadJson);

        //        var response = CommonUtil.RestfulPost(this.PrintedUrl, uploadJson);
        //        log.Debug("PrintedUrl = " + this.PrintedUrl);

        //        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        //        {
        //            log.Debug("PrintedUpdate error StatusCode=" + response.StatusCode);
        //            //throw new Exception("");
        //        }

        //        log.Debug("PrintedUpdate StatusCode=" + response.StatusCode);

        //        if (response.IsSuccessful)
        //            log.Debug("PrintedUpdate OK" + response.Content);

        //        log.Debug(" ======== PrintedUpdate call end  =======");

        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("PrintedUpdate Exception :" + ex.Message);
        //        throw ex;
        //    }

        //}
    }
}
