import { Component, OnInit } from '@angular/core';

import { CardService } from '../Services/card-service';

import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';

import { ImageDirective } from '../Directives/image.directive';

@Component({
    selector: 'card',
    templateUrl: './card.component.html',
    styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
    
    private card;

    constructor(        
    private cardService: CardService,
    private location: Location,
    private route: ActivatedRoute
    ) { }

    ngOnInit(): void {
        this.getCard();
      }

      getCard(): void {
        const id = this.route.snapshot.paramMap.get('id');        
        this.cardService.getCard(id)
          .subscribe(card => this.card = card);          
      }
     
      goBack(): void {
        this.location.back();
      }

      save() {
        this.cardService.updateCard(this.card)
        .subscribe(res => {
          this.goBack()
        })
      }

}