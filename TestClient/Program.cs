
using Zapper.Net;

var client = new ZapperClient(new Zapper.Net.Objects.ZapperClientOptions
{
    LogLevel = Microsoft.Extensions.Logging.LogLevel.Trace
});

var r= await client.Api.Account.GetBalancesAsync("0x64E807d36a59E28265167e1473E0DF83821Dc291");
var x = "";