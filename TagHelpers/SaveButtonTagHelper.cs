using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersMVC.TagHelpers
{
    [HtmlTargetElement("button-save")]
    public class SaveButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("type", "submit");
            output.Attributes.Add("class", "btn btn-outline-success");
            output.Content.Append("Kaydet ");
            output.Content.AppendHtml("<i class='fa fa-save'></i>");


            base.Process(context, output);
        }
    }
}
