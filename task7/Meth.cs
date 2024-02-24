namespace task7;

public class Meth
{


   public double PI ;
   public double E;


    public double Abs(double value)
    {

        if(value<0)
        {
            return value*(-1);
        }
        else 
        return value;
    }
  public float Abs(float value)
  {

        if(value<0)
        {
            return value*(-1);
        }
        else 
        return value;
    }


    public int Abs(int value)
    {

      if(value<0)
        {
            return value*(-1);
        }
        else 
        return value;

    }

    public double Pow (double x, double y)
     {
           double a=x;
        
        for (int i = 0; i <= y ; i++)
     
        {

             x*=a;
        }
        return x;

     }
      

      public double Sqrt(int d)
      {
           
        for(int i= 1;i<=d;i++)
        {
             double a =i;
           if(i*i==d)
           {
            return i;
           }
          
        }
        return 0;
     
      }  
     public int Max(int val1, int val2)
         {

               if(val1>val2)
               {

                       return val1;

               }
               else{
                return val2;
               }

         } 


 public int Min(int val1, int val2)
         {

               if(val1<val2)
               {

                       return val1;

               }
               else{
                return val2;
               }

         } 

  }




