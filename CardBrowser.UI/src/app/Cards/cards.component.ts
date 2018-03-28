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
  private allCards;
  private types: [{}];
  
  constructor(
    private cardService: CardService
  ) {

  }

  ngOnInit() {
    this.types = [{ name: 'City', value: 1 },
    { name: 'Resource', value: 2 },
    { name: 'Scene', value: 3 },
    { name: 'Armor', value: 4 },
    { name: 'Infantry', value: 5 }];
    this.cardService.getCards().subscribe(res => this.fillCards(res));
  }

  fillCards(cardArray) {
    this.allCards = cardArray.map(card => card);
    this.cards = this.allCards;
  }

  filterbyTypes(event) {
    this.cards = this.allCards.filter(card => card.CardTypeId == event.target.value)
  }

  filterbyRarity(event) {
    //TODO: implement filter by rarity
  }
}