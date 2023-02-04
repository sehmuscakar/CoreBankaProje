using CoreBankaProje.Data.Context;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace CoreBankaProje.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]//bu şekilde bir element oluşturyor ve bu element ile çağırıyor bu isimle çağıracan view kısmında  
    public class GetAccountCount: TagHelper
    {
        public int ApplicationUserID { get; set; }
        private readonly BankContext _context;

        public GetAccountCount(BankContext context)
        {
            _context = context;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base:temel ,alakalı 
            var accountCount = _context.Accounts.Count(x=>x.ApplicationUserId==ApplicationUserID);//contexteki ıd ile yukardaki eşitse kaydı getir ilk ıd contexteki coğunluk 

            var html = $"<span class='badge bg-danger'>{accountCount}<span/>";

            output.Content.SetHtmlContent(html);
        }
    }
}
