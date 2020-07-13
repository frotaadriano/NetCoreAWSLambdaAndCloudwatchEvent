using Amazon.Lambda.CloudWatchEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System;
using System.Data;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace NetCoreAWSLambdaAndCloudwatchEvent
{
    public class Function
    {
        public string FunctionHandler(CloudWatchEvent<Object> ev, ILambdaContext context)
        {

            var eventReceived = JsonConvert.SerializeObject(ev);

            var datahora = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");
            LambdaLogger.Log($"Yes, logget at: {datahora}! Event received:{eventReceived}");
            return "ok";
        }
    }
}