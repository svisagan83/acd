/// <reference path="../angular.js" />
var stuResources = angular.module("stuResources", ["ngResource"]);
stuResources.factory("Studs", function Studs($resource) {
    return $resource("/api/students", {}, {
        query: { method: 'GET', params: {}, isArray: true }
    });
});