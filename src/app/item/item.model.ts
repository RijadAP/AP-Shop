export class Item{
    public IName: string;
    public IDateP: string;
    public IGender: string;
    public IColor: string;
    public IModel: string;
    public IPublisher: string;
    public IPrice: number;
    public IShipping: number;
    public ILocation: string;
    public ITotal: number;
    public IImage: string;
    public IAvailableQuantity: number;
    public IChosenQuantity: number;
    public ISelected: boolean;

    constructor(name: string, date: string, gender: string, color: string, model: string, publisher: string, price: number, ship: number, location: string, image: string, availableQ: number){
        this.IName = name;
        this.IDateP = date;
        this.IGender = gender;
        this.IColor  = color;
        this.IModel = model;
        this.IPublisher = publisher;
        this.IPrice = price;
        this.IShipping = ship;
        this.ILocation = location;
        this.ITotal  = 0;
        this.IImage = image;
        this.IAvailableQuantity = availableQ;
        this.IChosenQuantity = 1;
        this.ISelected = false;
    }
}