var app1 = angular.module('app', ['ngRoute']);

app1.controller('MyController', function ($scope) {

    $scope.isVisible = false;

    $scope.openTable = function() {
        $scope.isVisible = true;
    }

    $scope.fleetName = "Boeing";
    $scope.tailNumber = "224AS";
    $scope.systemName = "FMC";
    $scope.hardwarePartNumber = "176200-01-01";
    $scope.softwareName = "OPS";
    $scope.softwarePartNumber = "5569090-001";
    $scope.prePost = "PRE";
    $scope.ecNum = "54467";
});
