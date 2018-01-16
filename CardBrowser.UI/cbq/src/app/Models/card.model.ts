import { CardRarities } from '../Enums/card-rarities';
import { CardTypes } from '../Enums/card-types';

export class Card{
    private id: number;
    private name: string;
    private cardType: CardTypes;
    private cardRarity: CardRarities;
    private image: any; 
}