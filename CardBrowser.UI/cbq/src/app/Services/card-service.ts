import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { HttpClient, HttpHeaders } from '@angular/common/http';

import { CardComponent } from '../Card/card.component';

@Injectable()
export class CardService {

    private entityUrl = 'card';
    private baseUrl ='http://localhost:51700/api/';

    constructor(private http: HttpClient) { }

    getCard(id) {
        return this.http.get( this.baseUrl + this.entityUrl + "/" + id, { headers: new HttpHeaders('') })        
    }

    getCards() {
        return this.http.get( this.baseUrl + this.entityUrl, { headers: new HttpHeaders('') })        
    }
}