
function calbt()
{
//alert('good');
var msel = document.bt.msel.value;
var fsel = document.bt.fsel.value;
var msel2 = document.bt.msel2.value;
var fsel2 = document.bt.fsel2.value;
var cb = "";
var a = 0;
var b = 0;
var o = 0;
var la = 0;
var lo = 0;
var lb = 0;
var la2 = 0;
var lo2 = 0;
var lb2 = 0;
if (msel == "a")
{
la = 75;
lo = 25;
lb = 0;
}
else if (msel == "b")
{
la = 0;
lb = 75;
lo = 25;
}
else if (msel == "o")
{
la = 0;
lb = 0;
lo = 100;
}
else if (msel == "ab")
{
la = 50;
lb = 50;
lo = 0;
}
if (fsel == "a")
{
la2 = 75;
lb2 = 0;
lo2 = 25;
}
else if (fsel == "b")
{
la2 = 0;
lb2 = 75;
lo2 = 25;
}
else if (fsel == "o")
{
la2 = 0;
lb2 = 0;
lo2 = 100;
}
else if (fsel == "ab")
{
la2 = 50;
lb2 = 50;
lo2 = 0;
}
var crh1 = 0;
var crh2 = 0;
if (msel2 == "n" && fsel2 == "n") {crh1 = 0; crh2=100;}
else if (msel2 == "p" && fsel2 == "n") {crh1 = 75; crh2=25;}
else if (msel2 == "n" && fsel2 == "p") {crh1 = 75; crh2=25;}
else if (msel2 == "p" && fsel2 == "p") {crh1 = 93.75; crh2=6.25;}
var aa = la * la2 / 100;
var ab = (la * lb2 + lb * la2)/ 100;
var ao = (la * lo2 + lo * la2)/ 100;
var bb = lb * lb2/ 100;
var bo = (lb * lo2 + lo * lb2)/ 100;
var oo = lo * lo2/ 100;
var resa = aa + ao;
var resb = bb + bo;
var resab = ab;
var reso = oo;
document.bt.resa.value = resa;
document.bt.resb.value = resb;
document.bt.resab.value = resab;
document.bt.reso.value = reso;
document.bt.res2.value = crh1;
document.bt.res3.value = crh2;
}