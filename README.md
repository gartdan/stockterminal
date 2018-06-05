### stx: A command line Stock Terminal ###
Stx is a command-line utility that retrieves real-time market pricing data from the IEX api. Written in .NET Core. It is cross-platform and can run on mac, linux and windows.

![Build Status](https://travis-ci.org/gartdan/stockterminal.svg?branch=master "Build Status")


![Screenshot](https://raw.githubusercontent.com/gartdan/stockterminal/master/screenshot.png "Stx Screenshot")


### Using Stx ###
Type stx -h to see help.
- stx --s <ticker list> : e.g. stx -s msft,aapl,goog,amzn,pvtl,docu,sfix,mu,nvida,intc,v,ma,gs,jpm,bac,tsla,twtr,fb
- stx --c <ticker> : e.g. stx -c msft to  see chart data
- stx --c <ticker> -t <timeframe> : valid timeframes are: 5y, 2y, 1y, ytd, 6m, 3m, 1m, 1d, date/YYYYDDMM
- stx --news <ticker>
- stx --stats <ticker>


The plan is to implement the rest of the IEX API.



### License ###
Copyright (c) 2018. All Rights Reserved.

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.