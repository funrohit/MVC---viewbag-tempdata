
<h2>====================This is Viewbag data=================</h2>
<h2>@ViewBag.a1</h2>
<h2>@ViewBag.a2</h2>
<h2>@ViewBag.a3</h2>
<h2>@ViewBag.a4</h2>
<ul>
    @foreach (var i in ViewBag.list)
    {
        <li>@i</li>
    }
</ul>
<h2>================<u>This is Viewdata</u> ==================</h2>
<h3>@ViewData["b1"]</h3>
<h3>@ViewData["b2"]</h3>
<h3>@ViewData["b3"]</h3>
<h3>@ViewData["b4"]</h3>
<ul>
    @foreach (var item in (List<string>)ViewData["list"])
    {
        <li>@item</li>
    }
</ul>
<h2>================This is TempData==================</h2>
<h3>@TempData["c1"]</h3>
<h3>@TempData["c2"]</h3>
<h3>@TempData["c3"]</h3>
<h3>@TempData["c3"]</h3>
