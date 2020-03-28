import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { MotorsComponent } from './motors/motors.component';
import { MeasuresComponent } from './measures/measures.component';
import { MotorsEditComponent } from './motors/motors-edit/motors-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    MotorsComponent,
    MeasuresComponent,
    MotorsEditComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: MotorsComponent, pathMatch: 'full' },
      { path: 'measures', component: MeasuresComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
