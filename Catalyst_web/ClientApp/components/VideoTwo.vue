<template>
  <section>
    <div v-if="!videoPlayed" class="video-two">
      <div class="container">
        <img src="/assets/images/scratch-1-1.png" class="video-two__scratch" alt="">
        <div class="row">
          <div class="col-lg-7">
            <div class="video-two__content">
              <h2 class="video-two__title">
                We help you extend your knowledge base.<br />
                Let's take a tour.
              </h2>
              <a href="#" class="thm-btn" @click.prevent="playVideo">Learn More</a>
            </div>
          </div>
          <div class="col-lg-5 d-flex justify-content-lg-end justify-content-sm-start">
            <div class="my-auto">
              <a href="#" class="video-two__popup" @click.prevent="playVideo"><i class="fa fa-play"></i></a>
            </div>
          </div>
        </div>
      </div>
    </div>
    <video ref="videoPlayer" controls style="width: 100%;" v-show="videoPlayed">
      <source src="/assets/videos/CA_video.mp4" type="video/mp4">
      Your browser does not support the video tag.
    </video>
  </section>
</template>

<script>
  export default {
    name: "VideoTwo",
    data() {
      return {
        videoPlayed: false
      };
    },
    methods: {
      playVideo() {
        this.videoPlayed = true;
        const videoPlayer = this.$refs.videoPlayer;
        videoPlayer.play();
      }
    }
  }
</script>

<style scoped>
</style>
