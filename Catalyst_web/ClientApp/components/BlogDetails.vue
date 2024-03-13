<template>
  <section class="blog-details">
    <div class="container">
      <div class="row">
        <div class="col-lg-8">
          <div class="blog-one__single">
            <div class="blog-one__image">
              <img src="/assets/images/custom/blog_770.jpg" alt="">

            </div><!-- /.blog-one__image -->
            <div class="blog-one__content text-center">
              <div class="blog-one__meta">
                <span data-toggle="tooltip" data-placement="top" title="" href="#" v-bind:data-original-title="translations.PostedOn + ': ' + formatDateMonth(blog.created)"><i class="fa fa-calendar-alt"></i></span>
                <span data-toggle="tooltip" data-placement="top" title="" href="#" v-bind:data-original-title="translations.PostedBy + ': ' + blog.authorEng"><i class="fa fa-user"></i></span>
              </div><!-- /.blog-one__meta -->
              <h2 class="blog-one__title">
                {{blog.titleEng}}

              </h2><!-- /.blog-one__title -->
              <p class="blog-one__text level-description">
                <span class="level-text">{{blog.descriptionEng}}</span>
              </p><!-- /.blog-one__text -->

            </div><!-- /.blog-one__content -->
          </div><!-- /.blog-one__single -->
          <div class="share-block">
            <div class="left-block" v-if="blog.tag && blog.tag.length > 0">
              <p>{{translations.Tags}}: <span>{{ blog.tag.split(' ').join(', ') }}</span></p>
            </div><!-- /.left-block -->
            <div class="social-block">
              <a :href="linkedinShareUrl" target="_blank"><i class="fab fa-linkedin-in"></i></a>
              <a :href="facebookShareUrl" target="_blank"><i class="fab fa-facebook-f"></i></a>

            </div><!-- /.social-block -->
          </div><!-- /.share-block -->
         
        </div><!-- /.col-lg-8 -->
        <div class="col-lg-4">
          <div class="sidebar">
            <!--<div class="sidebar__single sidebar__search">
    <form action="#" class="sidebar__search-form">
      <input type="text" name="search" placeholder="Search here...">
      <button type="submit"><i class="fa fa-search"></i></button>
    </form>
  </div><!-- /.sidebar__single -->
            <div class="sidebar__single sidebar__post">
              <h3 class="sidebar__title">{{translations.LatestBlogs}}</h3><!-- /.sidebar__title -->
              <div class="sidebar__post-wrap" v-for="singleBlog in blogs" :key="singleBlog.id">
                <div class="sidebar__post__single mt-3">
                  <div class="sidebar__post-image">
                    <div class="inner-block"><img src="/assets/images/custom/blog_66.jpg" alt="Awesome Image"></div>
                    <!-- /.inner-block -->
                  </div><!-- /.sidebar__post-image -->
                  <div class="sidebar__post-content">
                    <h4 class="sidebar__post-title"><nuxt-link :to="`/blogs/${singleBlog.id}`">{{singleBlog.titleEng.slice(0, 20)}}</nuxt-link></h4>
                    <!-- /.sidebar__post-title -->
                  </div><!-- /.sidebar__post-content -->
                </div><!-- /.sidebar__post__single -->

              </div><!-- /.sidebar__post-wrap -->
            </div><!-- /.sidebar__single -->

            <div class="sidebar__single sidebar__tags" v-if="blog.tag && blog.tag.length > 0">
              <h3 class="sidebar__title">{{translations.Tags}}</h3><!-- /.sidebar__title -->
              <ul class="sidebar__tags-list">
                <li class="sidebar__tags-list-item">{{ blog.tag.split(' ').join(', ') }}</li>
              </ul><!-- /.sidebar__category-list -->
            </div><!-- /.sidebar__single -->
          </div><!-- /.sidebar -->
        </div><!-- /.col-lg-4 -->
      </div><!-- /.row -->
    </div><!-- /.container -->
  </section>
</template>

<script>
  // import Share from 'share';


  export default {
    name: "BlogDetails",
    methods: {
      formatDateMonth(date) {
        // Use this.$moment to format the date
        return this.$moment(date).format('MMM D');
      },

    },
    computed: {
      facebookShareUrl() {
        return `https://www.facebook.com/sharer/sharer.php?u=${encodeURIComponent(window.location.href)}`;
      },
      linkedinShareUrl() {
        const url = encodeURIComponent(window.location.href);
        const title = encodeURIComponent(this.blog.titleEng);
        return `https://www.linkedin.com/sharing/share-offsite/?url=${url}&title=${title}`;
      },
      translations() {
        return this.$store.state.translations;
      },
    },
    async fetch() {
      try {
        const response = await this.$axios.get(`/api/BlogDetails/${this.blogId}`); // Fetch data based on ID
        this.blog = response.data;

        const latestBlogs = await this.$axios.get(`/api/Blogs/Latest?currentBlogId=${this.blogId}`);
        this.blogs = latestBlogs.data;
      } catch (error) {
        // Handle errors
      }
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    },
    data() {
      return {
        blogs: [],
        blog: {},
        blogId: this.$route.params.id,
        blogUrl: ''
      };
    },
    mounted() {
      if (process.client) {
        this.blogUrl = window.location.href;
      }
    }
  };

  </script>

<style scoped>
  .blog-details .share-block .social-block button {
    display: inline-block;
    vertical-align: middle;
    text-align: center;
    color: #81868a;
    font-size: 18px;
    -webkit-transition: all .4s ease;
    transition: all .4s ease;
  }

    .blog-details .share-block .social-block button + button {
      margin-left: 38px;
    }

    .blog-details .share-block .social-block button:hover {
      color: #f16101;
    }

  .blog-details__author {
    border: 2px solid #f1f1f1;
    padding: 60px 60px;
    margin-top: 50px;
    margin-bottom: 60px;
  }
</style>
