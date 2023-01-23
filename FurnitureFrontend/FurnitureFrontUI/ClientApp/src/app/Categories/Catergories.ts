import { Part } from "../Parts/Parts";
import { Product } from "../products/Products";

export interface Category {
    id: number;
    name: string;
    description: string;
    products: Product[];
    parts: Part[];
}