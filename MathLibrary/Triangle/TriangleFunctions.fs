/// <summary>Triangle Math Functions</summary>
module TriangleFunctions
/// <summary>Calculate Triangle Area</summary>
/// <param name="tHeight">Triangle Height</param>
/// <param name="tBase">Triangle Base Size</param>
/// <returns>double - the triangle Area</returns>
let calcTriangleArea (tHeight : float) (tBase : float) :  double = (tHeight * tBase) / 2.0;

let calcTrianglePerimeter (tHeight : float) (tBase : float) (hypotenuse : float) :  double = tHeight + tBase + hypotenuse;

let calcTriangleHypotenuse (tHeight : float) (tBase : float) : double  = sqrt(tHeight**2 + tBase**2)

let calcTriangleLeg (tHeight : float) (thypotenuse : float) : double = sqrt( thypotenuse**2 - tHeight**2) 

let calTriangleAngle (thypotenuse : float) ( fSide : float) : double =  asin(fSide/ thypotenuse)