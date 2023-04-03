class program {
    static void Main(string[] args){
        StatisticNum();
    }
    static double StatisticNum(double num){
        Console.Write("Pls input number : ");
        int i = 0;
        for(int j = 0; j == i ; j++){
            double number = double.Parse(Console.ReadLine());
        } return Messege();
    }
    static double MaxMinMean(double number){
        return (StatisticNum(number) + number) / number ;
    }
    static void Messege(){
        string messege = Console.ReadLine();
        if (messege == "End"){
            if (messege == "Findmax"){
                return  ();
            } else if (messege == "Findmin"){
                return ();
            } else if (messege == "Findmean"){
                return MaxMinMean ;
            } else {
                Console.WriteLine("Invalid mode");
            }
        }
        
    }
}