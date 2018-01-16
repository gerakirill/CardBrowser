import { Routes } from '@angular/router';

import { CardComponent } from '../Card/card.component';
import { CardsComponent } from '../Cards/cards.component';

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