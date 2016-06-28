/// <reference path="../angular.js" />
var stuResources = angular.module("stuResources", ["ngResource"]);
stuResources.factory("Studs", function Studs($resource) {
    return $resource("/api/students1", {}, {
        query: { method: 'GET', params: {}, isArray: true }
    });
});