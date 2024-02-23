<template>
  <section class="blog-details">
    <div class="container">
        <div class="row">
            <div class="col-lg-8">
                <div class="blog-one__single">
                    <div class="blog-one__image">
                        <img src="/assets/images/blog-d-1-1.jpg" alt="">

                    </div><!-- /.blog-one__image -->
                    <div class="blog-one__content text-center">
                        <div class="blog-one__meta">
                            <a data-toggle="tooltip" data-placement="top" title="" href="#" data-original-title="Posted On Jan 19"><i class="fa fa-calendar-alt"></i></a>
                            <a data-toggle="tooltip" data-placement="top" title="" href="#" data-original-title="No Comments"><i class="fa fa-comments"></i></a>
                            <a data-toggle="tooltip" data-placement="top" title="" href="#" data-original-title="Posted By Admin"><i class="fa fa-user"></i></a>
                        </div><!-- /.blog-one__meta -->
                        <h2 class="blog-one__title">
                          {{news.titleEng}}

                        </h2><!-- /.blog-one__title -->
                        <p class="blog-one__text">Aelltes port lacus quis enim var sed efficitur turpis gilla sed sit
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has
                            been the industry’s standard dummy text ever since the 1500s, when an unknown printer took a
                            galley of type and scrambled it to make a type specimen book. It has survived not only five
                            centuries, but also the leap into electronic typesetting, remaining essentially unchanged.
                        </p><!-- /.blog-one__text -->
                        <p class="blog-one__text">It was popularised in the 1960s with the release of Letraset sheets
                            containing Lorem Ipsum passages, and more recently with desktop publishing software like
                            Aldus PageMaker including versions of lorem ipsum amet finibus eros. Lorem Ipsum is simply
                            dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s
                            standard dummy text ever since the 1500s, when an unknown printer took a galley of type and
                            scrambled it to make a type specimen book. It has survived not only five centuries, but also
                            the leap into electronic typesetting.</p><!-- /.blog-one__text -->
                        <p class="blog-one__text">It was popularised in the 1960s with the release of Letraset sheets
                            containing Lorem Ipsum passages, and more recently with desktop publishing software like
                            Aldus PageMaker including versions of lorem ipsum.</p><!-- /.blog-one__text -->
                    </div><!-- /.blog-one__content -->
                </div><!-- /.blog-one__single -->
                <div class="share-block">
                    <div class="left-block">
                        <p>Tags: <a href="#">Business,</a> <a href="#">Agency,</a> <a href="#">Technology</a></p>
                    </div><!-- /.left-block -->
                    <div class="social-block">
                        <a href="#"><i class="fab fa-twitter"></i></a>
                        <a href="#"><i class="fab fa-facebook-f"></i></a>
                        <a href="#"><i class="fab fa-instagram"></i></a>
                        <a href="#"><i class="fab fa-dribbble"></i></a>
                    </div><!-- /.social-block -->
                </div><!-- /.share-block -->
            </div><!-- /.col-lg-8 -->
            <div class="col-lg-4">
                <div class="sidebar">
                    <div class="sidebar__single sidebar__search">
                        <form action="#" class="sidebar__search-form">
                            <input type="text" name="search" placeholder="Search here...">
                            <button type="submit"><i class="fa fa-search"></i></button>
                        </form>
                    </div><!-- /.sidebar__single -->
                    <div class="sidebar__single sidebar__post">
                        <h3 class="sidebar__title">Latest Posts</h3><!-- /.sidebar__title -->
                        <div class="sidebar__post-wrap">
                            <div class="sidebar__post__single">
                                <div class="sidebar__post-image">
                                    <div class="inner-block"><img src="/assets/images/lp-1-1.jpg" alt="Awesome Image"></div>
                                    <!-- /.inner-block -->
                                </div><!-- /.sidebar__post-image -->
                                <div class="sidebar__post-content">
                                    <h4 class="sidebar__post-title"><a href="#">Pre launch mobile app marketing pitfalls</a></h4>
                                    <!-- /.sidebar__post-title -->
                                </div><!-- /.sidebar__post-content -->
                            </div><!-- /.sidebar__post__single -->
                            <div class="sidebar__post__single">
                                <div class="sidebar__post-image">
                                    <div class="inner-block"><img src="/assets/images/lp-1-2.jpg" alt="Awesome Image"></div>
                                    <!-- /.inner-block -->
                                </div><!-- /.sidebar__post-image -->
                                <div class="sidebar__post-content">
                                    <h4 class="sidebar__post-title"><a href="#">Social currency per- formance keywords or</a></h4>
                                    <!-- /.sidebar__post-title -->
                                </div><!-- /.sidebar__post-content -->
                            </div><!-- /.sidebar__post__single -->
                            <div class="sidebar__post__single">
                                <div class="sidebar__post-image">
                                    <div class="inner-block"><img src="/assets/images/lp-1-3.jpg" alt="Awesome Image"></div>
                                    <!-- /.inner-block -->
                                </div><!-- /.sidebar__post-image -->
                                <div class="sidebar__post-content">
                                    <h4 class="sidebar__post-title"><a href="#">Prioritize these items quarterly sales are at</a></h4>
                                    <!-- /.sidebar__post-title -->
                                </div><!-- /.sidebar__post-content -->
                            </div><!-- /.sidebar__post__single -->
                        </div><!-- /.sidebar__post-wrap -->
                    </div><!-- /.sidebar__single -->
                    <div class="sidebar__single sidebar__category">
                        <h3 class="sidebar__title">Categories</h3><!-- /.sidebar__title -->
                        <ul class="sidebar__category-list">
                            <li class="sidebar__category-list-item"><a href="#">Business</a></li>
                            <li class="sidebar__category-list-item"><a href="#">Introductions</a></li>
                            <li class="sidebar__category-list-item"><a href="#">One Page Template</a></li>
                            <li class="sidebar__category-list-item"><a href="#">Parallax Effects</a></li>
                            <li class="sidebar__category-list-item"><a href="#">New Technologies</a></li>
                            <li class="sidebar__category-list-item"><a href="#">Video Backgrounds</a></li>
                        </ul><!-- /.sidebar__category-list -->
                    </div><!-- /.sidebar__single -->
                    <div class="sidebar__single sidebar__tags">
                        <h3 class="sidebar__title">Tags</h3><!-- /.sidebar__title -->
                        <ul class="sidebar__tags-list">
                            <li class="sidebar__tags-list-item"><a href="#">Business,</a></li>
                            <li class="sidebar__tags-list-item"><a href="#">Agency,</a></li>
                            <li class="sidebar__tags-list-item"><a href="#">Technology,</a></li>
                            <li class="sidebar__tags-list-item"><a href="#">Parallax,</a></li>
                            <li class="sidebar__tags-list-item"><a href="#">Innovative,</a></li>
                            <li class="sidebar__tags-list-item"><a href="#">Professional,</a></li>
                            <li class="sidebar__tags-list-item"><a href="#">Experience,</a></li>
                        </ul><!-- /.sidebar__category-list -->
                    </div><!-- /.sidebar__single -->
                </div><!-- /.sidebar -->
            </div><!-- /.col-lg-4 -->
        </div><!-- /.row -->
    </div><!-- /.container -->
</section>
</template>

<script>
  export default {
    name: "NewsDetails",
    async fetch() {
      const newsId = this.$route.params.id; // Get news ID from route parameters
      try {
        const response = await this.$axios.get(`/api/NewsDetails/${newsId}`); 
        this.news = response.data;
      } catch (error) {
        // Handle errors
      }
    },
    data() {
      return {
        news: {},
      };
    },
  };
</script>

<style scoped>

</style>
