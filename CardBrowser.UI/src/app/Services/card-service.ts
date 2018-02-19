import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http, Response } from '@angular/http';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Config } from '../config';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { CardComponent } from '../Card/card.component';

@Injectable()
export class CardService {
    
    private entityUrl = 'card';
    private baseUrl ='http://localhost:51700/api/';
    
    constructor(private http: HttpClient, private config : Config) { }

    getCard(id) {
        return this.http.get( this.config.get["baseUrl"] + this.entityUrl + "/" + id, { headers: new HttpHeaders('') })
        .catch(this.handleError)        
    }

    getCards() {
        return this.http.get( this.baseUrl + this.entityUrl, { headers: new HttpHeaders('') })        
        .catch(this.handleError)
    }

    handleError(error: Response | any) {        
        let errMsg: string;    
        if (error instanceof Response) {
          let body = error.json() || '';    
          let err = body.Errors ? body.Errors[0] : body.Message || JSON.stringify(body);         
          errMsg = err;
        } else {
          errMsg = error.Message ? error.Message : error.toString();
        }
        console.log = error(errMsg);
        return Observable.throw(errMsg);
      }
}