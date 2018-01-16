import { Directive, OnInit, Input } from '@angular/core';
import { Http } from '@angular/http';
import { ɵBROWSER_SANITIZATION_PROVIDERS, DomSanitizer } from '@angular/platform-browser';

@Directive({
  selector: '[image]',
  providers: [ɵBROWSER_SANITIZATION_PROVIDERS],
  host: {
    '[src]': 'sanitizedImageData'
  }
})
export class ImageDirective implements OnInit {
  imageData: any;
  sanitizedImageData: any;
  
  @Input('image') img: string;

  constructor(private http: Http,
    private sanitizer: DomSanitizer) { }

  ngOnInit() {
    this.imageData = 'data:image/jpg;base64,' + this.img;
    this.sanitizedImageData = this.sanitizer.bypassSecurityTrustUrl(this.imageData);
  }
}