using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersMVC.TagHelpers
{
    //Birinci kullanım şeklinde attributes'te tanımladığımız 3 parametreyi de kullanmak zorundayız.
    //[HtmlTargetElement("generic-button", Attributes = "icon-name, class-name, name")]

    //İkinci kullanım şekli daha esnektir. İstediğimiz parametreleri tercih edebiliriz.
    [HtmlTargetElement("generic-button", Attributes = "icon-name")]
    [HtmlTargetElement("generic-button", Attributes = "class-name")]
    [HtmlTargetElement("generic-button", Attributes = "name")]
    public class GenericButtonTagHelper : TagHelper
    {
        public string IconName { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("class", ClassName);
            output.Content.AppendHtml($"<i class='{IconName}'></i> {Name}");

            base.Process(context, output);
        }
    }
}
