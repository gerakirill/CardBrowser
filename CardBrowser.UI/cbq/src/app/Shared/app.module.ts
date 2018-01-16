import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CardComponent } from '../Card/card.component';
import { CardsComponent } from '../Cards/cards.component';
import { ImageDirective } from '../Directives/image.directive';

import { HttpClientModule, HttpClient } from '@angular/common/http';

import { CardService } from '../Services/card-service';

import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { routes } from '../Shared/app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    CardComponent,
    CardsComponent,
    ImageDirective
    
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    HttpModule,

    RouterModule.forRoot(routes)
  ],
  providers: [
    CardService,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
