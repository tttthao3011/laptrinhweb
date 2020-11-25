<?php

/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| Here is where you can register all of the routes for an application.
| It's a breeze. Simply tell Laravel the URIs it should respond to
| and give it the controller to call when that URI is requested.
|
*/

Route::get('/', function () {
    return view('welcome');
});
Route::get('/products', function () {
 return view('product');
});
Route::get('index', ['as'=>'home', 'uses'=>'HomeController@index']);
Route::get('productdetail/{MaSP}', ['as'=>'proddetail', 'uses'=>'HomeController@getProductdetail']);