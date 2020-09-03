// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class MYCLASSNAME : MonoBehaviour {

void  calbt (){
//alert('good');
FIXME_VAR_TYPE msel= document.bt.msel.value;
FIXME_VAR_TYPE fsel= document.bt.fsel.value;
FIXME_VAR_TYPE msel2= document.bt.msel2.value;
FIXME_VAR_TYPE fsel2= document.bt.fsel2.value;
FIXME_VAR_TYPE cb= "";
FIXME_VAR_TYPE a= 0;
FIXME_VAR_TYPE b= 0;
FIXME_VAR_TYPE o= 0;
FIXME_VAR_TYPE la= 0;
FIXME_VAR_TYPE lo= 0;
FIXME_VAR_TYPE lb= 0;
FIXME_VAR_TYPE la2= 0;
FIXME_VAR_TYPE lo2= 0;
FIXME_VAR_TYPE lb2= 0;
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
FIXME_VAR_TYPE crh1= 0;
FIXME_VAR_TYPE crh2= 0;
if (msel2 == "n" && fsel2 == "n") {crh1 = 0; crh2=100;}
else if (msel2 == "p" && fsel2 == "n") {crh1 = 75; crh2=25;}
else if (msel2 == "n" && fsel2 == "p") {crh1 = 75; crh2=25;}
else if (msel2 == "p" && fsel2 == "p") {crh1 = 93.75f; crh2=6.25f;}
FIXME_VAR_TYPE aa= la * la2 / 100;
FIXME_VAR_TYPE ab= (la * lb2 + lb * la2)/ 100;
FIXME_VAR_TYPE ao= (la * lo2 + lo * la2)/ 100;
FIXME_VAR_TYPE bb= lb * lb2/ 100;
FIXME_VAR_TYPE bo= (lb * lo2 + lo * lb2)/ 100;
FIXME_VAR_TYPE oo= lo * lo2/ 100;
FIXME_VAR_TYPE resa= aa + ao;
FIXME_VAR_TYPE resb= bb + bo;
FIXME_VAR_TYPE resab= ab;
FIXME_VAR_TYPE reso= oo;
document.bt.resa.value = resa;
document.bt.resb.value = resb;
document.bt.resab.value = resab;
document.bt.reso.value = reso;
document.bt.res2.value = crh1;
document.bt.res3.value = crh2;
}
}