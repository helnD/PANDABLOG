'use strict';

const webpack = require('webpack');
const path = require('path');

const bundleFolder = "./wwwroot/assets/";
const srcFolder = "./wwwroot/pandablog/";


module.exports = {
    
    entry: [
        srcFolder + "src/index.js" 
    ], 
    devtool: "source-map",
    output: {
        filename: "bundle.js",
        publicPath: 'assets/',
        path: path.resolve(__dirname, bundleFolder)
    },
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/,
                exclude: /(node_modules)/,
                loader: "babel-loader",
                query: {
                    presets: ["es2015", "stage-0", "react"]
                }
            }
        ]
    },
    
    plugins: [
    ]
};