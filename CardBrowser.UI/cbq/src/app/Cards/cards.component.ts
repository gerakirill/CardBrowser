import { Component, OnInit } from '@angular/core';

import { CardService } from '../Services/card-service';

import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';

import { ImageDirective } from '../Directives/image.directive';

@Component({
    selector: 'cards',
    templateUrl: './cards.component.html',
    styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {   

    private cards;   
  
    constructor(
      private cardService: CardService
    ) {
  
    }
  
    ngOnInit() {        
      this.cardService.getCards().subscribe(res => this.fillCards(res));
    }
  
    fillCards(cardArray) {
      this.cards = cardArray.map(card => card);           
    }
  
    filterbyTypes(event){   
      // TODO: implement filter by types
    }
  
    filterbyRarity(event){
      //TODO: implement filter by rarity
    }
}