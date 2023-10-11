

public class Grid
{
    public int h; //The hight of the grid 
    public int w; //The width of the grid 
    public int x;
    public int y;
    public  List<Tuple<int, int>> obstacle = new List<Tuple<int, int>>();
    public Grid(int X, int Y, int H, int W, List<Tuple<int, int>> obstacles)
    {
        x = X;
        y = Y;
        h = H;
        w = W;
        foreach (var xy in obstacles)
        {
            obstacle.Add(xy);
        }
    }


}
