import { Routes } from '@angular/router';

import { CardComponent } from '../app/Card/card.component';
import { CardsComponent } from '../app/Cards/cards.component';

export const routes: Routes = [
    {
        path: "cards/edit/:id",
        component: CardComponent
    },
    {
        path: "cards",
        component: CardsComponent
    }
];