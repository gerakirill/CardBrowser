import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule  } from "@angular/forms";

import { AppComponent } from './app.component';
import { CardComponent } from '../app/Card/card.component';
import { CardsComponent } from '../app/Cards/cards.component';
import { ImageDirective } from '../app/Directives/image.directive';

import { HttpClientModule, HttpClient } from '@angular/common/http';

import { CardService } from '../app/Services/card-service';

import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { routes } from '../app/app-routing.module';

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
    FormsModule,

    RouterModule.forRoot(routes)
  ],
  providers: [
    CardService,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
