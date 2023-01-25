import { Part } from "../Parts/Parts";
import { Category } from "../Categories/Catergories";

export interface Product {
  id: number;
  name: string;
  price: number;
  created: Date;
  // picture: string;
  likeCount: number;
  parts: Part[];
  categories: Category[];
  modified: Date;
  interest: number;
  
}
