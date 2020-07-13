using Amazon.Lambda.CloudWatchEvents;
using Amazon.Lambda.Core;
using System;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace NetCoreAWSLambdaAndCloudwatchEvent
{
    public class Function
    {
        public string FunctionHandler(CloudWatchEvent<Object> ev, ILambdaContext context)
        {
            return "ok";
        }
    }
}