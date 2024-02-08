<template>
  <section class="about-two">
    <div class="container">
      <div class="row">
        <div class="col-xl-6">
          <div class="about-two__content">
            <div class="block-title text-left">
              <h2 class="block-title__title">Welcome to Catalyst Academy</h2><!-- /.block-title__title -->
            </div><!-- /.block-title -->
            <p class="about-two__text">Catalyst Academy is a personal development and business academy that provides a range of programs and services designed to help teenagers develop the skills, knowledge, and confidence they need to succeed in both their personal and professional lives.</p><!-- /.about-two__text -->
            <div class="about-two__single-wrap">
              <div class="about-two__single">
                <div class="about-two__single-icon">
                  <i class="kipso-icon-professor"></i><!-- /.kipso-icon-professor -->
                </div><!-- /.about-two__single-icon -->
                <div class="about-two__single-content">
                  <p class="about-two__single-text">
                    Start learning from
                    our experts
                  </p><!-- /.about-two__single-text -->
                </div><!-- /.about-two__single-content -->
              </div><!-- /.about-two__single -->
              <div class="about-two__single">
                <div class="about-two__single-icon">
                  <i class="kipso-icon-knowledge"></i><!-- /.kipso-icon-professor -->
                </div><!-- /.about-two__single-icon -->
                <div class="about-two__single-content">
                  <p class="about-two__single-text">
                    Enhance your skills
                    with us now
                  </p><!-- /.about-two__single-text -->
                </div><!-- /.about-two__single-content -->
              </div><!-- /.about-two__single -->
            </div><!-- /.about-two__single-wrap -->
            <a href="#" class="thm-btn">Learn More</a><!-- /.thm-btn -->
          </div><!-- /.about-two__content -->
        </div><!-- /.col-lg-6 -->
        <div class="col-xl-6 d-flex justify-content-xl-end justify-content-sm-center">
          <div class="about-two__image">
            <span class="about-two__image-dots"></span><!-- /.about-two__image-dots -->
            <img src="/assets/images/about-1-1.jpg" alt="">
            <div class="about-two__count">
              <div class="about-two__count-text">
                Trusted by
                <span class="counter">1000</span>
              </div><!-- /.about-two__count-text -->
            </div><!-- /.about-two__count -->
          </div><!-- /.about-two__image -->
        </div><!-- /.col-lg-6 -->
      </div><!-- /.row -->
    </div><!-- /.container -->

<!--    <video controls>
      <source :src="videoUrl" type="video/mp4">
      Your browser does not support the video tag.
    </video>-->

  </section>
</template>

<script>
    export default {
    name: "AboutTwo",
    data() {
      return {
        videoUrl: ''
      };
    },
    mounted() {
      // Call your API to fetch the video data
      this.fetchVideoData();
    },
    methods: {
      async fetchVideoData() {
        try {
          const response = await this.$axios.get('/api/video/7ac5539a-2a72-49b4-a7a8-bcaa63f5c727');
          // Assuming your API returns the video data as a Blob
          const blob = new Blob([response.data], { type: 'video/mp4' });
          this.videoUrl = 'https://localhost:7226/api/video/7ac5539a-2a72-49b4-a7a8-bcaa63f5c727';
          console.log(this.videoUrl);
          console.log(blob);
        } catch (error) {
          console.error('Error fetching video data:', error);
        }
      }
    }
    }
</script>

<style scoped>

</style>
