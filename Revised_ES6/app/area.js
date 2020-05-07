
function circle(radius)
{
    return Math.PI*radius*radius;
}
function rectangle(length,breadth)
{
    return length*breadth;
}
function cylinder(radius,height)
{
    return ((2*Math.PI*radius*height) + (2*Math.PI*radius*radius));
}

export {circle,rectangle,cylinder}