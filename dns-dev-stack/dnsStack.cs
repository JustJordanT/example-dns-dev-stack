using System.Linq.Expressions;
using Pulumi;
using Cloudflare = Pulumi.Cloudflare;

class dnsStack : Stack
{
    public dnsStack()
    {
        var foobar = new Cloudflare.Record("foobar", new Cloudflare.RecordArgs
        {
            ZoneId = "temp1234567",
            Name = "temp_record",
            Value = "192.168.0.111",
            Type = "A",
            Ttl = 3600
        });
    }
}
