using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogS.ViewComponents
{
    public class NavigationViewComponent : ViewComponent 
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Factory.StartNew(() => { return View(); });
        }
    }
}
/*
 * @section Styles{
    <link rel = "stylesheet" href = "~/vendor/bootstrap/css/bootstrap-wysihtml5.css" />
}
<!--
@section Scripts
{
    <script src="https://cdn.ckeditor.com/ckeditor5/21.0.0/classic/ckeditor.js"></script>
    <script>
        ClassicEditor
            .create(document.querySelector('.textarea'))
            .catch(error => {
                console.error(error);
            });
        $(".custom-file-input").on("change" function() {
            var filename = $(this).val().split("\\").pop();
            $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
    });
    </script>
}
    -->
 */
