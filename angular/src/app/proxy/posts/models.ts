import type { PostType } from './post-type.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdatePostDto {
  title: string;
  type: PostType;
  content: string;
}

export interface PostDto extends AuditedEntityDto<string> {
  title?: string;
  type: PostType;
  content?: string;
}
