#pragma checksum "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a962206394655eb15f7295d02987d016ca2bbab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\_ViewImports.cshtml"
using YOYOTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\_ViewImports.cshtml"
using YOYOTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a962206394655eb15f7295d02987d016ca2bbab0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed711cbb9448a1465d94491b60cb8d9091f976e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YOYOTest.Models.YOYOTestTrack>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("play"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 255px; width:500px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/button-png.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
  h1 {
  background: rgba(255, 255, 255, 0.8);
  box-shadow: 0px 1px 10px 2px rgba(0, 0, 0, 0.2);
  border-bottom: 3px solid #00bfeb;
  font-size: calc(1em + 1vmax);
  }

  .counter {
  display: inline-flex;
  cursor: pointer;
  width: 300px;
  height: 300px;
  max-width: 100%;
  position: relative;
  justify-content: center;
  align-items: center;
  font-size: calc(1em + 1vmin);
  transition: height .2s ease-in-out;
  background: #fff;
  border-radius: 50%;
  box-shadow: 0px 1px 10px 2px rgba(0, 0, 0, 0.2);
  margin: 1em 0;
  }

  .percentage {
  position: absolute;
  text-align: center;
  top: 50%;
  left: 0;
  right: 0;
  vertical-align: middle;
  transform: translate3d(0, -50%, 0);
  }

  canvas {
  position: absolute;
  top: 0;
  left: 0;
  }

  input {
  width: 200px;
  }

  body {
  font-family: 'Open Sans', sans-serif;
  text-align: center;
  }
</style>

<div id=""TimeDistance"">
  <div class=""row"">
    <div class=""playbtn"" onclick=""playbtn(");
            WriteLiteral("event)\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a962206394655eb15f7295d02987d016ca2bbab05940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-6 col-sm-3 startbtn"" style=""display: none"">
      <div class=""counter"" data-cp-percentage=""75"" data-cp-color=""#00bfeb""></div>
    </div>
  </div>

  <div class=""row"">
    <div>NEXT<br />SHUTTLE<br /><span id=""nextshuttletime"">00:</span> s&nbsp;&nbsp;</div> &nbsp;&nbsp;
    <div style=""height: 60px;  border-left: 2px solid black;""></div>
    &nbsp;&nbsp;
    <div>TOTAL<br />TIME <br />
      <div id=""timer"">
        <span hidden=""true"" id=""hours"">00:</span>
        <span id=""mins"">00:</span>
        <span id=""seconds"">00</span> m
      </div> &nbsp;&nbsp;
    </div> &nbsp;&nbsp;
    <div style=""height: 60px;  border-left: 2px solid black;""></div>
    &nbsp;&nbsp;
    <div>TOTAL<br />DISTANCE <br /><span id=""totalDistance"">00:0</span>m</div>
  </div>
</div>

<div class=""row"">
  <table id=""trackTable"" style=""height: 500px"" class=""table table-striped table-hover table-responsive"" >
");
#nullable restore
#line 92 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
     for (var i = 0; i < Model.players.Count(); i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <td>\r\n          ");
#nullable restore
#line 96 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
     Write(Html.HiddenFor(it => it.players[i].id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td> &nbsp;\r\n          ");
#nullable restore
#line 99 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
     Write(Html.DisplayFor(it => it.players[i].name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </td>
        <td onclick=""warn(event)"">
          &nbsp; &nbsp; <button class=""btn btn-primary button tdwarn"">Warn</button>
        </td>
        <td onclick=""stop(event)"">
          &nbsp; &nbsp; <button class=""btn btn-warning button tdstop"">Stop</button>&nbsp; &nbsp;
        </td>
        <td>
          <div class=""btn-group"" >
            <button class=""btn btn-white btn-sm dropdown-toggle"" onclick=""openMenus(event)"" type=""button""
            aria-haspopup=""true"" aria-expanded=""false"">
             <span class=""clsLevel"">0</span>-<span class=""clsShuttle"">0</span>
            </button>
            <div class=""dropdown-menu"">
              <div class=""dropdown-item"" >Level : <span style=""width: 50px"" class=""clsLevel float-right p-1"" onclick=""updateVal(event)"">0</span>
              <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 3357, "\"", 3365, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"levelinput d-none\"/>\r\n              </div>\r\n              <div class=\"dropdown-item\" >Shuttle : <span style=\"width: 50px\" class=\"clsShuttle float-right p-1\" onclick=\"updateVal(event)\">0</span>\r\n              <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3600, "\"", 3608, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"shuttleinput d-none\"/>\r\n              </div>\r\n              <div class=\"dropdown-item\" ><button class=\"btn btn-sm btn-primary\" onclick=\"save(event)\">Update</button> </div>\r\n            </div>\r\n          </div>\r\n        </td>\r\n      </tr>\r\n");
#nullable restore
#line 125 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </table>
</div>

<script type=""text/javascript"">
  var level, shuttle, levelTime, mdlspeed, mdlStarttime;
  var commonIndex = 0;
  var circleProgress, wrapper;

  function openMenus(event){
    var parentNode = event.currentTarget.parentNode.parentNode;
    $(parentNode.querySelector('.btn-group')).addClass('show');
    $(parentNode.querySelector('.dropdown-menu')).addClass('show');
  }

  function  updateVal(event)
  {
    var parentNode = event.currentTarget.parentNode.parentNode.parentNode;
    $(parentNode.querySelector('.clsLevel')).addClass('d-none');
    $(parentNode.querySelector('.clsShuttle')).addClass('d-none');
    $(parentNode.querySelector('.levelinput')).removeClass('d-none');
    $(parentNode.querySelector('.shuttleinput')).removeClass('d-none');
    $(parentNode.querySelector('.levelinput')).val(parentNode.querySelector('.clsLevel').innerText);
    $(parentNode.querySelector('.shuttleinput')).val(parentNode.querySelector('.clsShuttle').innerText);
");
            WriteLiteral(@"  }

  function save(event){
    var parentNode = event.currentTarget.parentNode.parentNode.parentNode.parentNode.parentNode;
    $(parentNode.querySelectorAll('.clsLevel')).text($(parentNode.querySelector('.levelinput')).val());
    $(parentNode.querySelectorAll('.clsShuttle')).text($(parentNode.querySelector('.shuttleinput')).val());
    $(parentNode.querySelector('.clsLevel')).removeClass('d-none');
    $(parentNode.querySelector('.clsShuttle')).removeClass('d-none');
    $(parentNode.querySelector('.levelinput')).addClass('d-none');
    $(parentNode.querySelector('.shuttleinput')).addClass('d-none');
    $(parentNode.querySelector('.btn-group')).removeClass('show');
    $(parentNode.querySelector('.dropdown-menu')).removeClass('show');
     
  }

  function AssignVal(indexval) {
  commonIndex = indexval;
  var model = ");
#nullable restore
#line 167 "C:\MyData\AppSource\MVCApp\YOYOTest\Views\Home\Index.cshtml"
         Write(Html.Raw(Json.Serialize(@Model.fitnessratings)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
  level = model[indexval].speedLevel;
  shuttle = model[indexval].shuttleNo;
  levelTime = parseFloat(model[indexval].levelTime) * (1000);
  mdlspeed = model[indexval].speed;
  mdlStartSec = model[indexval + 1].startTime;
  $('#nextshuttletime').text(model[indexval + 1].levelTime);
  $('#totalDistance').html(model[indexval].accumulatedShuttleDistance);
  }

  function stop(event) {
  var parentNode = event.target.parentNode.parentNode;
  $(parentNode.querySelector('.tdwarn')).css(""display"", ""none"");
  $(parentNode.querySelector('.tdstop')).css(""display"", ""none"");
  $(parentNode.querySelectorAll('.clsShuttle')).text(shuttle);
  $(parentNode.querySelectorAll('.clsLevel')).text(level);
  }

  function warn(event) {
  var parentNode = event.target.parentNode.parentNode;
  console.log(parentNode.innerHTML);
  $(parentNode.querySelector('.tdwarn')).removeClass(""btn-primary"").addClass(""btn-secondary"");
  }

  $(document).ready(function () {
  var hours = 0;
  var mins = 0;
  var seconds ");
            WriteLiteral(@"= 0;
  var Starttimeval = new Date();
  var Resttimeval = new Date();

  var setStarttimeval = new Date(Starttimeval.setSeconds(0));
  var setResttimeval = new Date(Resttimeval.setSeconds(0));

  var minToMilli = 0; var secToMilli = 0;
  var curMilliSec = 0;
  var currenttime = 0;


  function startTimer() {
  timex = setTimeout(function () {
  setStarttimeval.setSeconds(levelTime / 1000);
  setResttimeval.setSeconds(mdlStartSec);

  seconds++;
  currenttime++;

  if (setStarttimeval.getSeconds() < currenttime) {
  currenttime = 0;
  AssignVal(commonIndex + 1);
  $('.counter').click();
  }

  if (setResttimeval.getSeconds() > curMilliSec) {
  //callStartTime      
  console.log('startYes');
  }

  if (seconds > 59) {
  seconds = 0;
  mins++;
  minToMilli = mins * 60;
  if (mins > 59) {
  mins = 0;
  hours++;
  if (hours < 10) {
  $(""#hours"").text(""0"" + hours + "":"");
  } else $(""#hours"").text(hours + "":"");
  }
  if (mins < 10) {
  $(""#mins"").text(""0"" + mins + "":"");
 ");
            WriteLiteral(@" } else $(""#mins"").text(mins + "":"");
  }
  if (seconds < 10) {
  $(""#seconds"").text(""0"" + seconds);
  } else {
  $(""#seconds"").text(seconds);
  }
  startTimer();
  }, 1000);
  }

 $("".play"").click(function () {
  startTimer();
   document.querySelector("".play"").style.display = ""none"";
  document.querySelector("".startbtn"").style.display = ""block"";
  AssignVal(0);
  }); 

  });

  function playbtn(event) {
");
            WriteLiteral(@"  setTimeout(function(){
    $('.counter').click();
  },100)
  }

  document.addEventListener(""DOMContentLoaded"", function () {

  circleProgress = (function (selector) {
  wrapper = document.querySelectorAll(selector);
  Array.prototype.forEach.call(wrapper, function (wrapper, i) {
  var wrapperWidth,
  wrapperHeight,
  percent,
  innerHTML,
  context,
  lineWidth,
  centerX,
  centerY,
  radius,
  newPercent,
  speed,
  from,
  to,
  duration,
  start,
  strokeStyle,
  text;

  var getValues = function () {
  wrapperWidth = parseInt(window.getComputedStyle(wrapper).width);
  wrapperHeight = wrapperWidth;
  percent = 10;

  innerHTML = '<span class=""percentage""></span><canvas class=""circleProgressCanvas"" width=""' + (wrapperWidth * 2) + '"" height=""' + wrapperHeight * 2 + '""></canvas>';
  wrapper.innerHTML = innerHTML;
  text = wrapper.querySelector("".percentage"");
  canvas = wrapper.querySelector("".circleProgressCanvas"");
  wrapper.style.height = canvas.style.width = canva");
            WriteLiteral(@"s.style.height = wrapperWidth + ""px"";
  context = canvas.getContext('2d');
  centerX = canvas.width / 2;
  centerY = canvas.height / 2;
  newPercent = 0;
  speed = 1;
  from = 0;
  to = 100;
  duration = levelTime;
  lineWidth = 20;
  radius = canvas.width / 2 - lineWidth;
  strokeStyle = wrapper.getAttribute('data-cp-color');
  start = new Date().getTime();
  };

  function animate() {
  requestAnimationFrame(animate);
  var time = new Date().getTime() - start;
  if (time <= duration) {
  var x = easeInOutQuart(time, from, to - from, duration);
  newPercent = x;
  text.innerHTML = ""Level :"" + level + "" <br/> Shuttle :"" + shuttle + ""<br/>"" + mdlspeed + ""km/h"";
  drawArc();
  }
  }

  function drawArc() {
  var circleStart = 1.5 * Math.PI;
  var circleEnd = circleStart + (newPercent / 50) * Math.PI;
  context.clearRect(0, 0, canvas.width, canvas.height);
  context.beginPath();
  context.arc(centerX, centerY, radius, circleStart, 4 * Math.PI, false);
  context.lineWidth = lineWid");
            WriteLiteral(@"th;
  context.strokeStyle = ""#ddd"";
  context.stroke();
  context.beginPath();
  context.arc(centerX, centerY, radius, circleStart, circleEnd, false);
  context.lineWidth = lineWidth;
  context.strokeStyle = strokeStyle;
  context.stroke();

  }
  var update = function () {
  getValues();
  animate();
  }
  update();

  var btnUpdate = document.querySelectorAll("".btn-update"")[0];

  wrapper.addEventListener(""click"", function () {
  update();
  });

  var resizeTimer;
  window.addEventListener(""resize"", function () {
  clearTimeout(resizeTimer);
  resizeTimer = setTimeout(function () {
  clearTimeout(resizeTimer);
  start = new Date().getTime();
  update();
  }, 250);
  });
  });

  function easeInOutQuart(t, b, c, d) {
  if ((t /= d / 2) < 1) return c / 2 * t * t * t * t + b;
  return -c / 2 * ((t -= 2) * t * t * t - 2) + b;
  }

  });

  circleProgress('.counter');

  function getRandom(min, max) {
  return Math.random() * (max - min) + min;
  }
   });

</script");
            WriteLiteral(">\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YOYOTest.Models.YOYOTestTrack> Html { get; private set; }
    }
}
#pragma warning restore 1591
