import { NgModule } from '@angular/core';

import { PostRoutingModule } from './post-routing.module';
import { PostComponent } from './post.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    PostComponent
  ],
  imports: [
  
    PostRoutingModule,
    SharedModule
  ]
})
export class PostModule { }
