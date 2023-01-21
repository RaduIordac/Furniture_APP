import { Category } from "../Categories/Catergories";
import { Product } from "../Products";

export interface Part {
    id: number;
    name: string;
    quantityInStock: number;
    price: number;
    products: Product[];
    categories: Category[];
    picture: string;
}