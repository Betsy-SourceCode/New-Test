﻿var app = angular.module('myApp', []);  //创建模块
app.controller('ProductPriceController', function ($scope) {
    $scope.IndexList = function () {
        $.ajax({
            url: "/NewEmailDomainPT/NewEmailDomainPT/IndexData",
            data: $('#Myform').serialize(),
            type: "POST",
            dataType: "json",
            success: function (data) {
                if (data.length == 0) {
                    $("#notfindlist").remove();   //empty-子节点清空，不会删除本身
                    //第一种;
                    $("#OAContent").append("<tr id='notfindlist'><td colspan='6' class='text-center' style='color:red;font-size:20px'>未找到任何记录</td></tr>");
                    $scope.List = null;
                    $scope.$apply();
                }
                else {
                    $.each(data, function (key, value) {

                    })
                }



              
            }
        });
    }
})