import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { PostDto, PostService } from '@proxy/posts';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss'],
  providers: [ListService],
})
export class PostComponent implements OnInit {
  post = { items: [], totalCount: 0 } as PagedResultDto<PostDto>;

  constructor(public readonly list: ListService, private postService: PostService) {}

  ngOnInit() {
    const postStreamCreator = (query) => this.postService.getList(query);

    this.list.hookToQuery(postStreamCreator).subscribe((response) => {
      this.post = response;
    });
  }
}