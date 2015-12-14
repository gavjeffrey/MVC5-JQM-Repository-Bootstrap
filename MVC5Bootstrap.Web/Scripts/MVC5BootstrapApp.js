'use strict';

var MVC5BootstrapApp = (function ($) {
    $(document).ready(function () {
        $("[data-role='navbar']").navbar();
        $("[data-role='header'], [data-role='footer']").toolbar();

        $("#menu[data-role=panel] ul").listview();
        $("#menu[data-role=panel]").enhanceWithin().panel();

        $("#user-detail[data-role=panel] ul").listview();

        $("#user-detail[data-role=panel]").enhanceWithin().panel();
    });

    document.addEventListener('touchmove', function (e) { e.preventDefault(); }, false);

    $(document).on("pagechange", function () {
        var scrollElement = '#' + $.mobile.activePage.attr('id') + ' > .wrapper';

        var myScroll = new IScroll(scrollElement, {
            mouseWheel: true,
            scrollbars: true,
            scrollX: false,
            scrollY: true,
            preventDefault: false,
            interactiveScrollbars: true
        });
    });

    $(document).on("pagecreate", function () {

        $(document).on("swipeleft swiperight", function (e) {
            // We check if there is no open panel on the page because otherwise
            // a swipe to close the left panel would also open the right panel (and v.v.).
            // We do this by checking the data that the framework stores on the page element (panel: open).
            if ($(".ui-page-active").jqmData("panel") !== "open") {
                if (e.type === "swipeleft") {
                    $("#user-detail").panel("open");
                } else if (e.type === "swiperight") {
                    $("#menu").panel("open");
                }
            }
        });

        $(".ui-collapsible-heading-app > a").bind("click", function (e) {
            document.location = $(this).attr('href');
        });
    });

    $(document).on("pageinit", "#filter-demo-page", function () {
        $("#autocomplete").on("filterablebeforefilter", function (e, data) {
            var $ul = $(this),
                $input = $(data.input),
                value = $input.val(),
                html = "";
            $ul.html("");
            if (value && value.length > 2) {
                $ul.html("<li><div class='ui-loader'><span class='ui-icon ui-icon-loading'></span></div></li>");
                $ul.listview("refresh");
                $.ajax({
                    url: "/api/Customer/" + $input.val(),
                    dataType: "json",
                    crossDomain: true,
                    error: function (err, s) {
                        debugger
                        alert(err);
                    }
                })
                .then(function (response) {
                    $.each(response, function (i, val) {
                        html += "<li>" + val.FirstName + " " + val.Surname + "</li>";
                    });
                    $ul.html(html);
                    $ul.listview("refresh");
                    $ul.trigger("updatelayout");
                });
            }
        });
    });

})(jQuery);