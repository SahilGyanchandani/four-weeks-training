class Car{
    make:string;
    model:string;
    year:number;
    constructor(make:string,model:string,year:number)
    {
        this.make=make
        this.model=model
        this.year=year

    }
    displayCarInfo(){
        console.warn(`${this.make} ${this.model} (${this.year})`);
     }
}
    const C = new Car("Nissan","GTR",2022);
    C.displayCarInfo()