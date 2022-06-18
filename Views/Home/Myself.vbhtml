﻿@Code
    ViewData("Title") = "Myself"
End Code

<link rel="stylesheet" href="~/Content/customize.css" />
<h2>Myself</h2>
<div class="container main_part">
    @*<section class="main-section">
        <div class="div div1">div 1</div>
        <div class="flex-container">
            <div class="flex-item1">
                <div class="div div2">div 2</div>
                <div class="div div4">div 4</div>
            </div>
            <div class="flex-item2">
                <div class="div div3">div 3</div>
                <div class="div div5">div 5</div>
                <div class="div div6">div 6</div>
            </div>
        </div>
    </section>*@
    <h4>CSS practice</h4>
    <section class="main_section">
        <div class="div div1" style="resize:both; overflow:auto">
            <p>This is first div</p>
        </div>
        <div class="flex-container">
            <div class="div div2">
                <p>This is second div</p>
            </div>
            <div class="div div3">
                <p>This is third div</p>
            </div>
        </div>
        <div class="flex-container">
            <div class="flex-item">
                <div class="div div4">
                    <p>This is forth div</p>
                </div>
                <div class="div div6">
                    <div class="div aim" id="aim1">
                        <p>Linear</p>
                    </div>
                    <div class="div aim" id="aim2">
                        <p>ease</p>
                    </div>
                    <div class="div aim" id="aim3">
                        <p>ease in</p>
                    </div>
                    <div class="div aim" id="aim4">
                        <p>ease out</p>
                    </div>
                    <div class="div aim" id="aim5">
                        <p>ease in out</p>
                    </div>

                </div>
            </div>
            <div class="flex-item">
                <div class="div div5">
                    <img src="~/image/messi.jpeg" alt="Messi pic"height="100%" width="100%" style="border-radius: 30px; @*-webkit-box-reflect: below;*@"/>
                </div>
            </div>
        </div>





        <div class="div footer" style="background-image:linear-gradient(to right, red, green, yellow, black)">
            <p>This is footer div</p>

        </div>



    </section>


</div>

