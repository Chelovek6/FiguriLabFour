using FiguriLabFour;
//Наследование 
Point startPoint = new Point(0, 0);
Point endPoint = new Point(3, 4);
Point thirdPoint = new Point(6, 0);
Triangle triangle = new Triangle(startPoint, endPoint, thirdPoint);
Tetrahedron tetrahedron = new Tetrahedron(startPoint, endPoint, thirdPoint, 12);

//triangle.PrintInfo();
tetrahedron.PrintInfo();
    
//
Point FirstPoint = new Point(0, 0);
Point LastPoint = new Point(3, 4);
Line line = new Line(FirstPoint, LastPoint);
Square square = new Square(line);
Cube cube = new Cube(square, 10);

//startPoint.PrintInfo();
//line.PrintInfo();
//square.PrintInfo();
//cube.PrintInfo();

