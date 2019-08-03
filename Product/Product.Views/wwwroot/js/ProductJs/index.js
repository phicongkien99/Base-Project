var productController = function () {

    this.init = function () {
        loadData();
        registerEvents();
    }

    var registerEvents = function () {

    }

    var loadData = function () {
        $.ajax({
            type: "GET",
            url: "api/GetAllProduct",
            dataType: "json",
            success: function (response) {

                var html = '';
                $.each(response, function (key, value) {

                    html += "<tr><td>" + value.Name + "</td>"

                });
            }
        });
    }

}