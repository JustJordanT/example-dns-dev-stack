using System.Linq.Expressions;
using Pulumi;
using Cloudflare = Pulumi.Cloudflare;

class dnsStack : Stack
{
    public dnsStack()
    {
        var config = new Config();
        var cloudflareZoneId = "d6f9720445b2707cd691d547276085f6";
        
        var foobar = new Cloudflare.Record("foobar", new Cloudflare.RecordArgs
        {
            ZoneId = cloudflareZoneId,
            Name = "temp_record",
            Value = "192.168.0.111",
            Type = "A",
            Ttl = 3600
        });
    }
}
