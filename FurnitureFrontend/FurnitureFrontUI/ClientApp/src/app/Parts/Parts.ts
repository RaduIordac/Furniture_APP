import { Category } from "../Categories/Catergories";
import { Product } from "../products/Products";

export interface Part {
    id: number;
    name: string;
    quantityInStock: number;
    price: number;
    categories: Category[];
    picture: string;
    salesprice: number;
}